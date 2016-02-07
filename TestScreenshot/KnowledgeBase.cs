using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;

namespace Megajewel
{
    public class KnowledgeBase
    {
        MegajewelForm Form;
        
        public List<Gem> TrainingData = new List<Gem>();

        public List<Gem> TeachingQueue = new List<Gem>();

        public KnowledgeBase(MegajewelForm form)
        {
            Form = form;
        }

        private string filename = "KnowledgeBase.dat";

        internal void Load()
        {
            try
            {
                FileStream fs = new FileStream(filename, FileMode.Open);
                BinaryFormatter bf = new BinaryFormatter();
                TrainingData = (List<Gem>)bf.Deserialize(fs);
                TrainingData.ForEach((gm) => gm.Postdeserialization());
                fs.Close();
                Form.Log("Deserialized.");
            }
            catch (Exception ex)
            {
                Form.Log(ex.ToString());
            }
        }
        internal void Save()
        {
            Form.TaughtGem = null;
            Form.pictureboxTeaching.Image = new Bitmap(112, 112);
            Form.UpdateUI();
            try {
                TrainingData.ForEach((gm) => gm.Preserialization());
                FileStream fs = new FileStream(filename, FileMode.Create);
                BinaryFormatter bf = new BinaryFormatter();
                bf.Serialize(fs, TrainingData);
                fs.Close();
                Form.Log("Serialized.");
            } catch (Exception ex)
            {
                Form.Log(ex.ToString());
            } 
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pharmacy
{
    public class Pharmacy
    {
        private static int _id = 0;
        public string Name { get; set; }
        public int ID { get; set; }

        private List<Medicine> medicines;
        public Pharmacy(string name)
        {
            _id++;
            ID = _id;
            Name = name;
            medicines = new List<Medicine>()
            {
                new  Medicine{Name="Tramal",Price=5 },
                 new Medicine{Name="Tramadol",Price=5 },
                  new Medicine{Name="Tilidin",Price=5 }
            };

        }

        public List<Medicine> GetMedicine()
        {
            return medicines;
        }

        public void AddMedicine(Medicine m)
        {
            medicines.Add(m);
        }
        public void DeleteMedicine(int id)
        {
            for (int i=0; i<medicines.Count; i++)
            {
                if (id == medicines[i].ID)
                {
                    medicines.RemoveAt(i);
                }
            }
        }
        public void UpdateMedicine(int id, string name, float price)
        {
            Medicine medicine = GetMedicines(id);
            medicine.ID = id;
            medicine.Name = name;
            medicine.Price = price;
        }
        public Medicine GetMedicines(int id)
        {
            Medicine result = null;
            for (int i = 0; i < medicines.Count; i++)
            {
                if (id == medicines[i].ID)
                {
                    result = medicines[i];
                }
            }
            return result;

        }
    }

}

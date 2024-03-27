using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindownForm
{
    public class NhanVien
    {
        public string Name { get; set; }
        public string Sex { get; set; }
        public int MNV { get; set; }
        public string BirthDay { get; set; }
        public NhanVien(string name, string sex, int mNV, string birthDay)
        {
            Name = name;
            Sex = sex;
            MNV = mNV;
            BirthDay = birthDay;
        }

        public override string ToString()
        {
            return $"{Name}, {Sex}, {MNV}, {BirthDay}";
        }
    }
}

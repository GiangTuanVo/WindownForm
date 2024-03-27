using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindownForm.Model
{
    public class SinhVien
    {
        public string TenSV { get; set; }
        public int MaSV { get; set; }
        public DateTime BirthDay { get; set; }
        public SinhVien(string tenSV, int maSV, DateTime birthDay)
        {
            TenSV = tenSV;
            MaSV = maSV;
            BirthDay = birthDay;
        }
        public override string ToString()
        {
            return $"{TenSV}, {MaSV}, {BirthDay}";
        }
    }
}

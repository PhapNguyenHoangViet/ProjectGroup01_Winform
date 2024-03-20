using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Group01_QuanLyLuanVan.Model
{
    public class Nhom
    {
        private string nhomId;

        public Nhom() { }

        public Nhom(string nhomId)
        {
            this.nhomId = nhomId;
        }

        public string NhomId { get => nhomId; set => nhomId = value; }
    }
}

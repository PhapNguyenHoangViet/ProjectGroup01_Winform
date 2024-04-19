using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Group01_QuanLyLuanVan.Model
{
    public class MessageTask
    {
        private int tinNhanId;
        private string tinNhan;
        private string nguoiGuiId;
        private string nguoiNhanId;
        private DateTime thoiGian;
        private int yeuCauId;

        public MessageTask(int tinNhanId, string tinNhan, string nguoiGuiId, string nguoiNhanId, DateTime thoiGian, int yeuCauId)
        {
            this.tinNhanId = tinNhanId;
            this.tinNhan = tinNhan;
            this.nguoiGuiId = nguoiGuiId;
            this.nguoiNhanId = nguoiNhanId;
            this.thoiGian = thoiGian;
            this.yeuCauId = yeuCauId;
        }

        public int TinNhanId { get => tinNhanId; set => tinNhanId = value; }
        public string TinNhan { get => tinNhan; set => tinNhan = value; }
        public string NguoiGuiId { get => nguoiGuiId; set => nguoiGuiId = value; }
        public string NguoiNhanId { get => nguoiNhanId; set => nguoiNhanId = value; }
        public int YeuCauId { get => yeuCauId; set => yeuCauId = value; }
        public DateTime ThoiGian { get => thoiGian; set => thoiGian = value; }
    }
}
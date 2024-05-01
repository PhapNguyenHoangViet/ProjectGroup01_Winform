using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Group01_QuanLyLuanVan.Model
{
    public class ChatYeuCau
    {
        private int tinNhanId;
        private string nguoiGui;
        private string nguoiNhan;
        private string noiDung;
        private DateTime thoiGian;
        private int yeuCauId;
        private string avatarPath;

        public ChatYeuCau() { }
        public ChatYeuCau(string nguoiGui, string nguoiNhan, string noiDung, DateTime thoiGian, int yeuCauId, string avatarPath, int tinNhanId)
        {
            this.nguoiGui = nguoiGui;
            this.nguoiNhan = nguoiNhan;
            this.noiDung = noiDung;
            this.thoiGian = thoiGian;
            this.yeuCauId = yeuCauId;
            this.avatarPath = avatarPath;
            this.tinNhanId = tinNhanId;
        }

        public int TinNhanId { get => tinNhanId; set => tinNhanId = value; }
        public string NguoiGui { get => nguoiGui; set => nguoiGui = value; }
        public DateTime ThoiGian { get => thoiGian; set => thoiGian = value; }
        public string NguoiNhan { get => nguoiNhan; set => nguoiNhan = value; }
        public string NoiDung { get => noiDung; set => noiDung = value; }
        public int YeuCauId { get => yeuCauId; set => yeuCauId = value; }
        public string AvatarPath { get => avatarPath; set => avatarPath = value; }

    }
}

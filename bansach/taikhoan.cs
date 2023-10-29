using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bansach
{
    internal class taikhoan
    {
        private string tentaikhoan;
        private string matKhau;

        public taikhoan()
        {
        }

        public taikhoan(string tentaikhoan, string matKhau)
        {
            this.tentaikhoan=tentaikhoan;
            this.matKhau=matKhau;
        }

        public string Tentaikhoan { get => tentaikhoan; set => tentaikhoan=value; }
        public string MatKhau { get => matKhau; set => matKhau=value; }
    }
}

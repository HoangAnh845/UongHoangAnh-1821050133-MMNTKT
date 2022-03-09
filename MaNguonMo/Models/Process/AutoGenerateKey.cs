using System;
using System.Text.RegularExpressions;
namespace MaNguonMo.Models.Process{
    public class AutoGenerateKey{
        // Các phương thức cần xây dựng
        // Phương thức sinh mã tự động
        // Phương thức có kiểu trả về là gì ?
        // Nhận 1 tham số đầu vào (id của đối tượng muốn sinh mã)
        // Nếu đối tượng chưa có dữ liệu => cần khởi tạo 1 mã
        // Nếu đốt tượng đã có dữ liệu => lấy mã mới nhất làm tham số 
        // STD004 => Mã mới sinh ra là STD005
        // STD001 => STD002
        // Tách phần số phần chữ của tham số đầu vào id
        // Lấy phân số chuyển sang kiểu int và tăng lên một đơn vị
        // Bổ sung cả ký 0 còn thiếu, sau đó ghép với phần chữ 
        public string SinhMaTuDong(string id) { // truyen vao ID vd: "PS001"
            string newKey = ""; // ID moi
            string numPart = "", strPart = "", strPhanso = "";

            numPart = Regex.Match(id, @"\d+").Value; // lay ra phan so cua key "001"
            strPart = Regex.Match(id, @"\D+").Value; // lay ra phan chu cua key = "PS"

            int Phanso = Convert.ToInt32(numPart) + 1; // 2

            for(int i = 0; i < numPart.Length - Phanso.ToString().Length; i++) //(3 -1)
            {
                strPhanso += "0";
            }
            // strPhanso = "00"
            strPhanso += Phanso; // "00" + "2" = "002"
            newKey = strPart + strPhanso;  // "PS" + "002" = "PS002"
           
            return newKey;
        }
        
        // Xây dựng phương thức mã hóa dữ liệu
        // Xây dựng phương tính xử lý số liệu
    }
}
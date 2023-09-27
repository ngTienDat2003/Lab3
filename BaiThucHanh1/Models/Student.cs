using System.ComponentModel.DataAnnotations;

namespace BaiThucHanh1.Models
{
    public class Student
    {
        public int Id { get; set; }//Mã sinh viên

        [Required(ErrorMessage = "Vui lòng nhập họ tên.")]
        [StringLength(100, MinimumLength = 4, ErrorMessage = "Họ tên phải có ít nhất 4 ký tự và tối đa 100 ký tự.")]
        [Display(Name = "Họ tên")]
        public string? Name { get; set; } //Họ tên

        [Required(ErrorMessage = "Email bắt buộc phải được nhập")]
        [RegularExpression(@"[A-Za-z0-9._%+-]+@gmail\.com$", ErrorMessage = "Email không hợp lệ. Email phải có đuôi gmail.com.")]
        [Display(Name = "Email")]
        public string? Email { get; set; } //Email

        [Required(ErrorMessage = "Vui lòng nhập mật khẩu.")]
        [StringLength(100, MinimumLength = 8, ErrorMessage = "Mật khẩu phải có ít nhất 8 ký tự.")]
        [RegularExpression(@"^(?=.*[a-z])(?=.*[A-Z])(?=.*\d)(?=.*[^\da-zA-Z]).{8,}$", ErrorMessage = "Mật khẩu phải chứa ít nhất một ký tự viết hoa, một ký tự viết thường, một chữ số và một ký tự đặc biệt.")]
        [DataType(DataType.Password)]
        [Display(Name = "Mật khẩu")]
        public string? Password { get; set; }//Mật khẩu

        [Required(ErrorMessage = "Vui lòng chọn ngành học.")]
        [Display(Name = "Ngành học")]
        public Branch? Branch { get; set; }//Ngành học

        [Required(ErrorMessage = "Vui lòng chọn giới tính.")]
        [Display(Name = "Giới tính")]
        public Gender? Gender { get; set; }//Giới tính

        
        [Display(Name = "Hệ")]
        public bool IsRegular { get; set; }//Hệ: true-chính qui, false-phi cq

        [Required(ErrorMessage = "Vui lòng nhập địa chỉ.")]
        [DataType(DataType.MultilineText)]
        [Display(Name = "Địa chỉ")]
        public string? Address { get; set; }//Địa chỉ

        [Range(typeof(DateTime), "1/1/1963", "12/31/2005", ErrorMessage = "Ngày sinh phải nằm trong khoảng từ 1/1/1963 đến 31/12/2005.")]
        [DataType(DataType.Date)]
        [Required(ErrorMessage ="Vui lòng nhập ngày sinh")]
        public DateTime DateOfBorth { get; set; }//Ngày sinh

        [Required(ErrorMessage = "Vui lòng nhập điểm.")]
        [Display(Name = "Điểm")]
        [Range(0.0, 10.0, ErrorMessage = "Điểm phải nằm trong khoảng từ 0.0 đến 10.0.")]

        public double Score { get; set; }
    }
}

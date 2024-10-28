using System;
using System.Data;
using System.Data.OleDb;
using System.Configuration;
using System.Web.UI;

namespace WAPP_K215480106063
{
    public partial class TrangChu : System.Web.UI.Page
    {
        // Chuỗi kết nối đến cơ sở dữ liệu
        private string connectionString = ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString;

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                BindGridView();
            }
        }

        // Thêm bản ghi sinh viên mới
        protected void Them_SV_Click(object sender, EventArgs e)
        {
            using (OleDbConnection conn = new OleDbConnection(connectionString))
            {
                conn.Open();
                OleDbCommand cmd = new OleDbCommand("INSERT INTO TB_HaHuyNam (MaSinhVien, HoTen, NgaySinh, Lop, XepLoaiHocLuc) VALUES (@MaSinhVien, @HoTen, @NgaySinh, @Lop, @XepLoaiHocLuc)", conn);
                cmd.Parameters.AddWithValue("@MaSinhVien", TextBox_MaSinhVien.Text);
                cmd.Parameters.AddWithValue("@HoTen", TextBox_HoTen.Text);
                cmd.Parameters.AddWithValue("@NgaySinh", TextBox_NgaySinh.Text);
                cmd.Parameters.AddWithValue("@Lop", TextBox_Lop.Text);
                cmd.Parameters.AddWithValue("@XepLoaiHocLuc", TextBox_XepLoaiHocLuc.Text);

                cmd.ExecuteNonQuery();
                BindGridView();
                ClearFields();
            }
        }

        // Xóa bản ghi sinh viên
        protected void Xoa_SV_Click(object sender, EventArgs e)
        {
            using (OleDbConnection conn = new OleDbConnection(connectionString))
            {
                conn.Open();
                OleDbCommand cmd = new OleDbCommand("DELETE FROM TB_HaHuyNam WHERE MaSinhVien = @MaSinhVien", conn);
                cmd.Parameters.AddWithValue("@MaSinhVien", TextBox_MaSinhVien.Text);

                cmd.ExecuteNonQuery();
                BindGridView();
                ClearFields();
            }
        }

        // Chỉnh sửa thông tin sinh viên
        protected void ChinhSua_SV_Click(object sender, EventArgs e)
        {
            using (OleDbConnection conn = new OleDbConnection(connectionString))
            {
                conn.Open();
                OleDbCommand cmd = new OleDbCommand("UPDATE TB_HaHuyNam SET HoTen = @HoTen, NgaySinh = @NgaySinh, Lop = @Lop, XepLoaiHocLuc = @XepLoaiHocLuc WHERE MaSinhVien = @MaSinhVien", conn);
                cmd.Parameters.AddWithValue("@MaSinhVien", TextBox_MaSinhVien.Text);
                cmd.Parameters.AddWithValue("@HoTen", TextBox_HoTen.Text);
                cmd.Parameters.AddWithValue("@NgaySinh", TextBox_NgaySinh.Text);
                cmd.Parameters.AddWithValue("@Lop", TextBox_Lop.Text);
                cmd.Parameters.AddWithValue("@XepLoaiHocLuc", TextBox_XepLoaiHocLuc.Text);

                cmd.ExecuteNonQuery();
                BindGridView();
                ClearFields();
            }
        }

        // Phương thức xóa trống các trường TextBox sau khi thực hiện thao tác
        private void ClearFields()
        {
            TextBox_MaSinhVien.Text = "";
            TextBox_HoTen.Text = "";
            TextBox_NgaySinh.Text = "";
            TextBox_Lop.Text = "";
            TextBox_XepLoaiHocLuc.Text = "";
        }

        // BindGridView method using OleDb
        protected void BindGridView()
        {
            using (OleDbConnection conn = new OleDbConnection(connectionString))
            {
                OleDbDataAdapter da = new OleDbDataAdapter("SELECT * FROM TB_HaHuyNam", conn);
                DataTable dt = new DataTable();
                da.Fill(dt);
                GridView1.DataSource = dt;
                GridView1.DataBind();
            }
        }
    }
}

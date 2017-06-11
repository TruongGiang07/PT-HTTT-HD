package bankmgmt.POJO;

/**
 * Created by TruongGiang on 6/11/2017.
 */
public class UserLogin {
    private int MaNV;
    private String UserName;
    private String Password;
    private String HoTen;
    private int LoaiNV;

    public int getMaNV() {
        return MaNV;
    }

    public void setMaNV(int maNV) {
        MaNV = maNV;
    }

    public String getUserName() {
        return UserName;
    }

    public void setUserName(String userName) {
        UserName = userName;
    }

    public String getPassword() {
        return Password;
    }

    public void setPassword(String password) {
        Password = password;
    }

    public String getHoTen() {
        return HoTen;
    }

    public void setHoTen(String hoTen) {
        HoTen = hoTen;
    }

    public int getLoaiNV() {
        return LoaiNV;
    }

    public void setLoaiNV(int loaiNV) {
        LoaiNV = loaiNV;
    }
}

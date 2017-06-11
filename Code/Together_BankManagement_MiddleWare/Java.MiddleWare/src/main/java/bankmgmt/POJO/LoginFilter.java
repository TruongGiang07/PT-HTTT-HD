package bankmgmt.POJO;

import java.util.Date;

/**
 * Created by TruongGiang on 5 /16/2017.
 */
public class LoginFilter {
    private String tenDN;
    private String matKhau;


    public String getTenDangNhap() {
        return tenDN;
    }

    public void setFromDate(String username) {
        this.tenDN = username;
    }

    public String getMatKhau() {
        return matKhau;
    }

    public void setToDate(String password) {
        this.matKhau = password;
    }
}

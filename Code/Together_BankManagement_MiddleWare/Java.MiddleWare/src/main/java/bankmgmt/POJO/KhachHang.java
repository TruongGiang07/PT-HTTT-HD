package bankmgmt.POJO;

import java.util.Date;

/**
 * Created by TruongGiang on 5/7/2017.
 */
public class KhachHang {
    private int maKhachHang;
    private String hoTen;
    private double soDuTaiKhoan;
    private Date ngaySinh;
    private boolean gioiTinh;
    private String diaChiThuongTru;
    private String diaChiLienLac;
    private String soCMND;
    private String dienThoai;
    private String email;
    private boolean tinhTrangHonNhan;
    private Date ngayLap;
    private boolean tinhTrangHoatDong;
    private int maCNDangky;

    public int getMaKhachHang() {
        return maKhachHang;
    }

    public void setMaKhachHang(int maKhachHang) {
        this.maKhachHang = maKhachHang;
    }

    public String getHoTen() {
        return hoTen;
    }

    public void setHoTen(String hoTen) {
        this.hoTen = hoTen;
    }

    public double getSoDuTaiKhoan() {
        return soDuTaiKhoan;
    }

    public void setSoDuTaiKhoan(double soDuTaiKhoan) {
        this.soDuTaiKhoan = soDuTaiKhoan;
    }

    public Date getNgaySinh() {
        return ngaySinh;
    }

    public void setNgaySinh(Date ngaySinh) {
        this.ngaySinh = ngaySinh;
    }

    public boolean isGioiTinh() {
        return gioiTinh;
    }

    public void setGioiTinh(boolean gioiTinh) {
        this.gioiTinh = gioiTinh;
    }

    public String getDiaChiThuongTru() {
        return diaChiThuongTru;
    }

    public void setDiaChiThuongTru(String diaChiThuongTru) {
        this.diaChiThuongTru = diaChiThuongTru;
    }

    public String getDiaChiLienLac() {
        return diaChiLienLac;
    }

    public void setDiaChiLienLac(String diaChiLienLac) {
        this.diaChiLienLac = diaChiLienLac;
    }

    public String getSoCMND() {
        return soCMND;
    }

    public void setSoCMND(String soCMND) {
        this.soCMND = soCMND;
    }

    public String getDienThoai() {
        return dienThoai;
    }

    public void setDienThoai(String dienThoai) {
        this.dienThoai = dienThoai;
    }

    public String getEmail() {
        return email;
    }

    public void setEmail(String email) {
        this.email = email;
    }

    public boolean isTinhTrangHonNhan() {
        return tinhTrangHonNhan;
    }

    public void setTinhTrangHonNhan(boolean tinhTrangHonNhan) {
        this.tinhTrangHonNhan = tinhTrangHonNhan;
    }

    public Date getNgayLap() {
        return ngayLap;
    }

    public void setNgayLap(Date ngayLap) {
        this.ngayLap = ngayLap;
    }

    public boolean isTinhTrangHoatDong() {
        return tinhTrangHoatDong;
    }

    public void setTinhTrangHoatDong(boolean tinhTrangHoatDong) {
        this.tinhTrangHoatDong = tinhTrangHoatDong;
    }

    public int getMaCNDangky() {
        return maCNDangky;
    }

    public void setMaCNDangky(int maCNDangky) {
        this.maCNDangky = maCNDangky;
    }
}

package bankmgmt.POJO;

import java.util.Date;

/**
 * Created by KhoaPham on 24/05/2017.
 */
public class NhanVien {
    private int maNhanVien;
    private String tenDangNhap;
    private String matKhau;
    private String hoTen;
    private Date ngaySinh;
    private boolean gioiTinh;
    private String diaChi;
    private String soDienThoai;
    private int maCNLamViec;
    private String tenChiNhanh;
    private int loaiNV;

    public int getLoaiNV() {
        return loaiNV;
    }

    public void setLoaiNV(int loaiNV) {
        this.loaiNV = loaiNV;
    }

    public void setGioiTinh(boolean gioiTinh) {
        this.gioiTinh = gioiTinh;
    }

    public boolean isGioiTinh() {
        return gioiTinh;
    }

    public String getTenChiNhanh() {
        return tenChiNhanh;
    }

    public void setTenChiNhanh(String tenChiNhanh) {
        this.tenChiNhanh = tenChiNhanh;
    }

    public int getMaNhanVien() {
        return maNhanVien;
    }
    public void setMaNhanVien(int maNhanVien) {
        this.maNhanVien = maNhanVien;
    }

    public String getTenDangNhap() {
        return tenDangNhap;
    }
    public void setTenDangNhap(String tenDangNhap) {
        this.tenDangNhap = tenDangNhap;
    }

    public String getMatKhau() {
        return matKhau;
    }
    public void setMatKhau(String matKhau) {
        this.matKhau = matKhau;
    }

    public String getHoTen() {
        return hoTen;
    }
    public void setHoTen(String hoTen) {
        this.hoTen = hoTen;
    }

    public Date getNgaySinh() {
        return ngaySinh;
    }
    public void setNgaySinh(Date ngaySinh) {
        this.ngaySinh = ngaySinh;
    }

    public String getDiaChi() {
        return diaChi;
    }
    public void setDiaChi(String diaChi) {
        this.diaChi = diaChi;
    }

    public String getSoDienThoai() {
        return soDienThoai;
    }
    public void setSoDienThoai(String soDienThoai) {
        this.soDienThoai = soDienThoai;
    }

    public int getMaCNLamViec() {
        return maCNLamViec;
    }
    public void setMaCNLamViec(int maCNLamViec) {
        this.maCNLamViec = maCNLamViec;
    }

}

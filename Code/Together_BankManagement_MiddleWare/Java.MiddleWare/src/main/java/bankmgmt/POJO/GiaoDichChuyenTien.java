package bankmgmt.POJO;

import java.util.Date;

/**
 * Created by TruongGiang on 6/5/2017.
 */
public class GiaoDichChuyenTien {
    private int maGD;
    private int soTienChuyen;
    private int maKhachHangChuyen;
    private int maKhachHangNhan;
    private int maNhanVien;
    private String noiDung;
    private Date ngayChuyen;

    public int getMaGD() {
        return maGD;
    }

    public void setMaGD(int maGD) {
        this.maGD = maGD;
    }

    public int getSoTienChuyen() {
        return soTienChuyen;
    }

    public void setSoTienChuyen(int soTienChuyen) {
        this.soTienChuyen = soTienChuyen;
    }

    public int getMaKhachHangChuyen() {
        return maKhachHangChuyen;
    }

    public void setMaKhachHangChuyen(int maKhachHangChuyen) {
        this.maKhachHangChuyen = maKhachHangChuyen;
    }

    public int getMaKhachHangNhan() {
        return maKhachHangNhan;
    }

    public void setMaKhachHangNhan(int maKhachHangNhan) {
        this.maKhachHangNhan = maKhachHangNhan;
    }

    public int getMaNhanVien() {
        return maNhanVien;
    }

    public void setMaNhanVien(int maNhanVien) {
        this.maNhanVien = maNhanVien;
    }

    public String getNoiDung() {
        return noiDung;
    }

    public void setNoiDung(String noiDung) {
        this.noiDung = noiDung;
    }

    public Date getNgayChuyen() {
        return ngayChuyen;
    }

    public void setNgayChuyen(Date ngayChuyen) {
        this.ngayChuyen = ngayChuyen;
    }
}

package bankmgmt.POJO;

import java.util.Date;

/**
 * Created by TruongGiang on 5/16/2017.
 */
public class TKGDViewModel {
    private Date ngayGiaoDich;
    private String tenTruSo;
    private String tenChiNhanh;
    private int slGDRutTien;
    private double soTienGDRutTien;
    private int slGDGuiTien;
    private double soTienGDGuiTien;
    private int slGDChuyenTien;
    private  double soTienGDChuyenTien;

    public Date getNgayGiaoDich() {
        return ngayGiaoDich;
    }

    public void setNgayGiaoDich(Date ngayGiaoDich) {
        this.ngayGiaoDich = ngayGiaoDich;
    }

    public String getTenTruSo() {
        return tenTruSo;
    }

    public void setTenTruSo(String tenTruSo) {
        this.tenTruSo = tenTruSo;
    }

    public String getTenChiNhanh() {
        return tenChiNhanh;
    }

    public void setTenChiNhanh(String tenChiNhanh) {
        this.tenChiNhanh = tenChiNhanh;
    }

    public int getSlGDRutTien() {
        return slGDRutTien;
    }

    public void setSlGDRutTien(int slGDRutTien) {
        this.slGDRutTien = slGDRutTien;
    }

    public double getSoTienGDRutTien() {
        return soTienGDRutTien;
    }

    public void setSoTienGDRutTien(double soTienGDRutTien) {
        this.soTienGDRutTien = soTienGDRutTien;
    }

    public int getSlGDGuiTien() {
        return slGDGuiTien;
    }

    public void setSlGDGuiTien(int slGDGuiTien) {
        this.slGDGuiTien = slGDGuiTien;
    }

    public double getSoTienGDGuiTien() {
        return soTienGDGuiTien;
    }

    public void setSoTienGDGuiTien(double soTienGDGuiTien) {
        this.soTienGDGuiTien = soTienGDGuiTien;
    }

    public int getSlGDChuyenTien() {
        return slGDChuyenTien;
    }

    public void setSlGDChuyenTien(int slGDChuyenTien) {
        this.slGDChuyenTien = slGDChuyenTien;
    }

    public double getSoTienGDChuyenTien() {
        return soTienGDChuyenTien;
    }

    public void setSoTienGDChuyenTien(double soTienGDChuyenTien) {
        this.soTienGDChuyenTien = soTienGDChuyenTien;
    }
}

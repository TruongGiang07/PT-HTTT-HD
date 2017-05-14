package bankmgmt.POJO;

import java.util.Date;

/**
 * Created by TruongGiang on 5/7/2017.
 */
public class TongKetGiaoDich {
    private int id;
    private Date ngayGiaoDich;
    private int maChiNhanh;
    private int maTruSo;
    private int slGDRutTien;
    private double soTienGDRutTien;
    private int slGDGuiTien;
    private double soTienGDGuiTien;
    private int slGDChuyenTien;
    private  double soTienGDChuyenTien;

    public int getId() {
        return id;
    }

    public void setId(int id) {
        this.id = id;
    }

    public Date getNgayGiaoDich() {
        return ngayGiaoDich;
    }

    public void setNgayGiaoDich(Date ngayGiaoDich) {
        this.ngayGiaoDich = ngayGiaoDich;
    }

    public int getMaChiNhanh() {
        return maChiNhanh;
    }

    public void setMaChiNhanh(int maChiNhanh) {
        this.maChiNhanh = maChiNhanh;
    }

    public int getMaTruSo() {
        return maTruSo;
    }

    public void setMaTruSo(int maTruSo) {
        this.maTruSo = maTruSo;
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

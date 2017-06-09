package bankmgmt.POJO;

import java.util.Date;

/**
 * Created by TruongGiang on 6/4/2017.
 */
public class TKGDDetailParam {
    private Date ngayGiaoDich;
    private int maTruSo;
    private int maChiNhanh;

    public Date getNgayGiaoDich() {
        return ngayGiaoDich;
    }

    public void setNgayGiaoDich(Date ngayGiaoDich) {
        this.ngayGiaoDich = ngayGiaoDich;
    }

    public int getMaTruSo() {
        return maTruSo;
    }

    public void setMaTruSo(int maTruSo) {
        this.maTruSo = maTruSo;
    }

    public int getMaChiNhanh() {
        return maChiNhanh;
    }

    public void setMaChiNhanh(int maChiNhanh) {
        this.maChiNhanh = maChiNhanh;
    }
}

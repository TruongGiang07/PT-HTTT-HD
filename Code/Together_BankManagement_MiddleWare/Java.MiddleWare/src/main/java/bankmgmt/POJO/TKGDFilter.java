package bankmgmt.POJO;

import java.util.Date;

/**
 * Created by TruongGiang on 5 /16/2017.
 */
public class TKGDFilter {
    private Date fromDate;
    private Date toDate;
    private int maTruSo;
    private int maChiNhanh;

    public Date getFromDate() {
        return fromDate;
    }

    public void setFromDate(Date fromDate) {
        this.fromDate = fromDate;
    }

    public Date getToDate() {
        return toDate;
    }

    public void setToDate(Date toDate) {
        this.toDate = toDate;
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

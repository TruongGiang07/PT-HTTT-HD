package src.main.java.bankmgmt.POJO;

import java.sql.Timestamp;

/**
 * Created by TruongGiang on 5/7/2017.
 */
public class GiaoDich{
	    private int magd;
	    private int sotiengd;
	    private int makh;
	    private int manv;
	    private int loaigd;
	    private Timestamp ngaygd;
	    
	    public GiaoDich() {}

	    public GiaoDich(int magd, int sotiengd, int makh, int manv, int loaigd, Timestamp ngaygd) {
	        this.magd = magd;
	        this.sotiengd = sotiengd;
	        this.makh = makh;
	        this.manv = manv;
	        this.loaigd = loaigd;
	        this.ngaygd = ngaygd;
	    }

	    public int getMagd() {
	        return magd;
	    }

	    public int getSotiengd() {
	        return sotiengd;
	    }

	    public int getMakh() {
	        return makh;
	    }

	    public int getManv() {
	        return manv;
	    }

	    public int getLoaigd() {
	        return loaigd;
	    }

	    public Timestamp getNgaygd() {
	        return ngaygd;
	    }

	    public void setMagd(int magd) {
	        this.magd = magd;
	    }

	    public void setSotiengd(int sotiengd) {
	        this.sotiengd = sotiengd;
	    }

	    public void setMakh(int makh) {
	        this.makh = makh;
	    }

	    public void setManv(int manv) {
	        this.manv = manv;
	    }

	    public void setLoaigd(int loaigd) {
	        this.loaigd = loaigd;
	    }

	    public void setNgaygd(Timestamp ngaygd) {
	        this.ngaygd = ngaygd;
	    }
	    
	    @Override
	    public String toString() {
	        return "magd: " + magd + " - " + "sotiengd: " + sotiengd + " - " + "ngaygd: " + ngaygd.toString() + " - " + "makh: " + makh + " - " + "manv: " + manv+ " - " + "loaigd: " + loaigd;
	    }
}

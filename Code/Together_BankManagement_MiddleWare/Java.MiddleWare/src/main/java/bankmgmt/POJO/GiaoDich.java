package bankmgmt.POJO;

import java.sql.Date;

/**
 * Created by TruongGiang on 5/7/2017.
 */
public class GiaoDich{
	    private int maGD;
	    private int soTienGD;
	    private int maKhachHang;
	    private int maNhanVien;
	    private int loaiGD;
	    private Date ngayGD;
	    
	    public int getMaGD() {
	        return maGD;
	    }

		 public void setMaGD(int maGD) {
	        this.maGD = maGD;
	    }
		
	    public int getSotiengd() {
	        return soTienGD;
	    }

		 public void setSotiengd(int soTienGD) {
	        this.soTienGD = soTienGD;
	    }
		
	    public int getMaKhachHang() {
	        return maKhachHang;
	    }

		 public void setMaKhachHang(int maKhachHang) {
	        this.maKhachHang = maKhachHang;
	    }
		
	    public int getMaNhanVien() {
	        return maNhanVien;
	    }

		public void setMaNhanVien(int maNhanVien) {
	        this.maNhanVien = maNhanVien;
	    }
		
	    public int getLoaigd() {
	        return loaigd;
	    }

		public void setLoaiGD(int loaiGD) {
	        this.loaiGD = loaiGD;
	    }
		
	    public Date getNgayGD() {
	        return ngayGD;
	    }

		public void setNgayGD(Timestamp ngayGD) {
	        this.ngayGD = ngayGD;
	    }

	    @Override
	    public String toString() {
	        return "maGD: " + maGD + " - " + "soTienGD: " + soTienGD + " - " + "ngayGD: " + ngayGD.toString() + " - " + "maKhachHang: " + maKhachHang + " - " + "maNhanVien: " + maNhanVien+ " - " + "loaiGD: " + loaiGD;
	    }
}

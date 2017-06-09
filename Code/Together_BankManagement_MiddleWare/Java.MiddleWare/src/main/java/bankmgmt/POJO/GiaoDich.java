package bankmgmt.POJO;

import java.util.Date;

/**
 * Created by TruongGiang on 5/7/2017.
 */
public class GiaoDich{
	    private int maGD;
	    private double soTienGD;
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

	public double getSoTienGD() {
		return soTienGD;
	}

	public void setSoTienGD(double soTienGD) {
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

	public int getLoaiGD() {
		return loaiGD;
	}

	public void setLoaiGD(int loaiGD) {
		this.loaiGD = loaiGD;
	}

	public Date getNgayGD() {
		return ngayGD;
	}

	public void setNgayGD(Date ngayGD) {
		this.ngayGD = ngayGD;
	}

	@Override
	    public String toString() {
	        return "maGD: " + maGD + " - " + "soTienGD: " + soTienGD + " - " + "ngayGD: " + ngayGD.toString() + " - " + "maKhachHang: " + maKhachHang + " - " + "maNhanVien: " + maNhanVien+ " - " + "loaiGD: " + loaiGD;
	    }
}

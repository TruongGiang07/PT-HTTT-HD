package bankmgmt.BusinessLayer;

import bankmgmt.DataAccessLayer.KhachHangDAL;
import bankmgmt.POJO.KhachHang;

import java.util.List;

/**
 * Created by TruongGiang on 5/7/2017.
 */
public class KhachHangBUS {
    public static List<KhachHang> getAll() {
        return KhachHangDAL.getAll();
    }

    public static List<KhachHang> getKHByID (int makh){
        return  KhachHangDAL.getKHByID(makh);
    }
	
	public static List<KhachHang> getKHByCMND (String cmnd){
        return  KhachHangDAL.getKHByCMND(cmnd);
    }

    public static boolean addKH(KhachHang kh) {
        return KhachHangDAL.addKH(kh);
    }

    public static boolean upKH(KhachHang kh) {
        return KhachHangDAL.upKH(kh);
    }

    public static boolean delKH(KhachHang kh){
        return KhachHangDAL.delKH(kh);
    }

}

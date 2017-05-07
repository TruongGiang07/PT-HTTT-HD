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

    public static boolean add(KhachHang kh) {
        return KhachHangDAL.add(kh);
    }
}

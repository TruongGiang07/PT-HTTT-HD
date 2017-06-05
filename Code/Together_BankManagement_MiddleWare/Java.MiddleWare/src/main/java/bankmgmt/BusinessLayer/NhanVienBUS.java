package bankmgmt.BusinessLayer;


import bankmgmt.DataAccessLayer.NhanVienDAL;
import bankmgmt.POJO.NhanVien;

import java.util.List;

/**
 * Created by KhoaPham on 24/5/2017.
 */
public class NhanVienBUS {
    public static List<NhanVien> getAll() {
        return NhanVienDAL.getAll();
    }
    public static boolean add(NhanVien nv) {
        return NhanVienDAL.add(nv);
    }
    public static boolean up(NhanVien nv) {
        return NhanVienDAL.up(nv);
    }
    public static List<NhanVien> getNVByID (int makh){
        return  NhanVienDAL.getNVByID(makh);
    }

    public static List<NhanVien> getNVByHoTen (String hoten){
        return  NhanVienDAL.getNVByHoTen(hoten);
    }
    public static boolean del(NhanVien nv){
        return NhanVienDAL.del(nv);
    }
}

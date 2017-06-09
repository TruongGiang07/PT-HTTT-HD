package bankmgmt.BusinessLayer;


import bankmgmt.DataAccessLayer.NhanVienDAL;
import bankmgmt.DataAccessLayer.TongKetGiaoDichDAL;
import bankmgmt.POJO.NhanVien;
import bankmgmt.POJO.TKGDViewModel;

import java.sql.Date;
import java.util.ArrayList;
import java.util.List;

/**
 * Created by KhoaPham on 24/5/2017.
 */
public class NhanVienBUS {
    public static List<NhanVien> getAll() {
        List<NhanVien> result = new ArrayList<NhanVien>();
        List<Object[]> temp = NhanVienDAL.getAll();

        for (Object[] obj : temp) {
            NhanVien item = new NhanVien();
            item.setMaNhanVien(Integer.valueOf(obj[0].toString()));
            item.setHoTen(obj[1].toString());
            item.setNgaySinh(Date.valueOf(obj[2].toString()));
            item.setSoDienThoai(obj[3].toString());
            item.setDiaChi(obj[4].toString());
            item.setGioiTinh(Boolean.valueOf(obj[5].toString()));
            item.setTenChiNhanh(obj[6].toString());
            item.setTenDangNhap(obj[7].toString());
            item.setMatKhau(obj[8].toString());
            result.add(item);
        }
        return result;
    }
    public static boolean add(NhanVien nv) {
        return NhanVienDAL.add(nv);
    }
    public static boolean up(NhanVien nv) {
        return NhanVienDAL.up(nv);
    }
    public static List<NhanVien> getNVByID (int makh){
        List<NhanVien> result = new ArrayList<NhanVien>();
        List<Object[]> temp = NhanVienDAL.getNVByID(makh);

        for (Object[] obj : temp) {
            NhanVien item = new NhanVien();
            item.setMaNhanVien(Integer.valueOf(obj[0].toString()));
            item.setHoTen(obj[1].toString());
            item.setNgaySinh(Date.valueOf(obj[2].toString()));
            item.setSoDienThoai(obj[3].toString());
            item.setDiaChi(obj[4].toString());
            item.setGioiTinh(Boolean.valueOf(obj[5].toString()));
            item.setTenChiNhanh(obj[6].toString());
            item.setTenDangNhap(obj[7].toString());
            item.setMatKhau(obj[8].toString());
            result.add(item);
        }
        return result;
    }

    public static List<NhanVien> getNVByHoTen (String hoten){
        List<NhanVien> result = new ArrayList<NhanVien>();
        List<Object[]> temp = NhanVienDAL.getNVByHoTen(hoten);

        for (Object[] obj : temp) {
            NhanVien item = new NhanVien();
            item.setMaNhanVien(Integer.valueOf(obj[0].toString()));
            item.setHoTen(obj[1].toString());
            item.setNgaySinh(Date.valueOf(obj[2].toString()));
            item.setSoDienThoai(obj[3].toString());
            item.setDiaChi(obj[4].toString());
            item.setGioiTinh(Boolean.valueOf(obj[5].toString()));
            item.setTenChiNhanh(obj[6].toString());
            item.setTenDangNhap(obj[7].toString());
            item.setMatKhau(obj[8].toString());
            result.add(item);
        }
        return result;
    }
    public static boolean del(NhanVien nv){
        return NhanVienDAL.del(nv);
    }
}

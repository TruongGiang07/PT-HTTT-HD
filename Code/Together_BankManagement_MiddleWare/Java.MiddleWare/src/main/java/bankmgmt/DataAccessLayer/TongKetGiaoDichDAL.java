package bankmgmt.DataAccessLayer;

import bankmgmt.POJO.TKGDDetailParam;
import bankmgmt.POJO.TKGDFilter;
import bankmgmt.POJO.TongKetGiaoDich;
import bankmgmt.Utilities.HibernateUtil;
import org.hibernate.HibernateException;
import org.hibernate.Session;
import org.hibernate.query.Query;

import java.util.List;

/**
 * Created by TruongGiang on 5/7/2017.
 */
public class TongKetGiaoDichDAL {
    public static List<TongKetGiaoDich> getAll()
    {
        List<TongKetGiaoDich> ds = null;
        Session session = HibernateUtil.getSessionFactory().openSession();
        try {
            String hql = "select tkgd from TongKetGiaoDich tkgd";
            Query query = session.createQuery(hql);
            ds = query.list();
        } catch (HibernateException ex) {
            System.err.println(ex);
        } finally {
            session.close();
        }
        return ds;
    }

    public static List<Object[]> getByFilter(TKGDFilter filter)
    {
        List<Object[]> ds = null;
        Session session = HibernateUtil.getSessionFactory().openSession();
        try {
            String hql = "select tkgd.ngayGiaoDich, ts.tenTruSo, cn.tenChiNhanh, tkgd.slGDRutTien, " +
                    "tkgd.soTienGDRutTien, tkgd.slGDGuiTien, tkgd.soTienGDGuiTien, tkgd.slGDChuyenTien, " +
                    "tkgd.soTienGDChuyenTien, ts.maTruSo, cn.maChiNhanh " +
                    " from TongKetGiaoDich tkgd, TruSo ts, ChiNhanh cn" +
                    " where tkgd.maTruSo = ts.maTruSo and tkgd.maChiNhanh = cn.maChiNhanh" +
                    " and tkgd.ngayGiaoDich between :fromDate and :toDate ";

            if (filter.getMaTruSo() > 0){
                hql += " and tkgd.maTruSo = " + filter.getMaTruSo();
            }
            if (filter.getMaChiNhanh() > 0){
                hql += " and tkgd.maChiNhanh = " + filter.getMaChiNhanh();
            }
            Query query = session.createQuery(hql);
            query.setDate("fromDate", filter.getFromDate());
            query.setDate("toDate", filter.getToDate());
            ds = query.list();
        } catch (HibernateException ex) {
            System.err.println(ex);
        } finally {
            session.close();
        }
        return ds;
    }

    public static List<Object[]> getDSGDByNgay(TKGDDetailParam opt){
        List<Object[]> ds = null;
        Session session = HibernateUtil.getSessionFactory().openSession();
        try {
            String hql = "select kh.MaKhachHang, kh.HoTen, kh.SoCMND, gd.SoTienGiaoDich, gd.LoaiGD " +
                    " from GiaoDich gd, KhachHang kh, ChiNhanh cn" +
                    " where gd.MaKHGiaoDich = kh.MaKhachHang and kh.MaCNDangky = cn.MaChiNhanh" +
                    " and gd.NgayGiaoDich = :ngayGD and cn.MaChiNhanh = :maCN and cn.MaTruSoTrucThuoc = :maTS " +
                    " UNION " +
                    " select kh.MaKhachHang, kh.HoTen, kh.SoCMND, gdct.SoTienChuyen, 3 as loaiGD " +
                    " from GiaoDichChuyenTien gdct, KhachHang kh, ChiNhanh cn" +
                    " where gdct.MaKHChuyen = kh.MaKhachHang and kh.MaCNDangky = cn.MaChiNhanh" +
                    " and gdct.NgayChuyen = :ngayGD and cn.MaChiNhanh = :maCN and cn.MaTruSoTrucThuoc = :maTS ";


            Query query = session.createSQLQuery(hql);

            query.setDate("ngayGD", opt.getNgayGiaoDich());
            query.setInteger("maCN", opt.getMaChiNhanh());
            query.setInteger("maTS", opt.getMaTruSo());
            ds = query.list();
        } catch (HibernateException ex) {
            System.err.println(ex);
        } finally {
            session.close();
        }
        return ds;
    }

    public static List<Object[]> getTotalByFilter(TKGDFilter filter)
    {
        List<Object[]> ds = null;
        Session session = HibernateUtil.getSessionFactory().openSession();
        try {
            String hql = "select SUM(tkgd.slGDRutTien), SUM(tkgd.soTienGDRutTien), " +
                    " SUM(tkgd.slGDGuiTien), SUM(tkgd.soTienGDGuiTien)," +
                    " SUM(tkgd.slGDChuyenTien), SUM(tkgd.soTienGDChuyenTien)" +
                    " from TongKetGiaoDich tkgd" +
                    " where tkgd.ngayGiaoDich between :fromDate and :toDate ";

            if (filter.getMaTruSo() > 0){
                hql += " and tkgd.maTruSo = " + filter.getMaTruSo();
            }
            if (filter.getMaChiNhanh() > 0){
                hql += " and tkgd.maChiNhanh = " + filter.getMaChiNhanh();
            }
            Query query = session.createQuery(hql);
            query.setDate("fromDate", filter.getFromDate());
            query.setDate("toDate", filter.getToDate());
            ds = query.list();
        } catch (HibernateException ex) {
            System.err.println(ex);
        } finally {
            session.close();
        }
        return ds;
    }
}

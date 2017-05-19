package bankmgmt.DataAccessLayer;

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
            String hql = "select tkgd.ngayGiaoDich, ts.tenTruSo, cn.tenChiNhanh, tkgd.slGDRutTien, tkgd.soTienGDRutTien, tkgd.slGDGuiTien, tkgd.soTienGDGuiTien, tkgd.slGDChuyenTien, tkgd.soTienGDChuyenTien " +
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
}

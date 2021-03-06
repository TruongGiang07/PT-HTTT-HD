package bankmgmt.DataAccessLayer;

import bankmgmt.POJO.GiaoDich;
import bankmgmt.Utilities.HibernateUtil;
import java.util.List;
import org.hibernate.HibernateException;
import org.hibernate.Session;
import org.hibernate.query.Query;

/**
 * Created by TruongGiang on 5/7/2017.
 */
public class GiaoDichDAL {
    public static List<GiaoDich> getAll()
    {
        List<GiaoDich> ds = null;
        Session session = HibernateUtil.getSessionFactory().openSession();
        try {
            String hql = "select gd from GiaoDich gd";
            Query query = session.createQuery(hql);
            ds = query.list();
        } catch (HibernateException ex) {
            System.err.println(ex);
        } finally {
            session.close();
        }
        return ds;
    }
	
	public static List<GiaoDich> getGDByKHCMND(String cmnd)
    {
        List<GiaoDich> ds = null;
        Session session = HibernateUtil.getSessionFactory().openSession();
        try {
            String hql = "select gd from GiaoDich gd where maKhachHang in (select kh.maKhachHang from KhachHang kh where kh.soCMND = )" + cmnd;
            Query query = session.createQuery(hql);
            ds = query.list();
        } catch (HibernateException ex) {
            System.err.println(ex);
        } finally {
            session.close();
        }
        return ds;
    }
	
	public static List<GiaoDich> getGDByDate(String ngaygd)
    {
        List<GiaoDich> ds = null;
        Session session = HibernateUtil.getSessionFactory().openSession();
        try {
            String hql = "select gd from GiaoDich gd where gd.ngayGD = )" + ngaygd;
            Query query = session.createQuery(hql);
            ds = query.list();
        } catch (HibernateException ex) {
            System.err.println(ex);
        } finally {
            session.close();
        }
        return ds;
    }
}


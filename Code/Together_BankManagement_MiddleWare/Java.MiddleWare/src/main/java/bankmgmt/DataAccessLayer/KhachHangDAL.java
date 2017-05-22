package bankmgmt.DataAccessLayer;

import bankmgmt.POJO.KhachHang;
import bankmgmt.Utilities.HibernateUtil;
import org.hibernate.HibernateException;
import org.hibernate.Session;
import org.hibernate.Transaction;
import org.hibernate.query.Query;

import java.util.List;

/**
 * Created by TruongGiang on 5/7/2017.
 */
public class KhachHangDAL {
    public static List<KhachHang> getAll()
    {
        List<KhachHang> ds = null;
        Session session = HibernateUtil.getSessionFactory().openSession();
        try {
            String hql = "select kh from KhachHang kh";
            Query query = session.createQuery(hql);
            ds = query.list();
        } catch (HibernateException ex) {
            System.err.println(ex);
        } finally {
            session.close();
        }
        return ds;
    }

    public static List<KhachHang> getKHByID( int makh)
    {
        List<KhachHang> ds = null;
        Session session = HibernateUtil.getSessionFactory().openSession();
        try {
            String hql = "select kh from KhachHang kh where kh.maKhachHang = " + makh;
            Query query = session.createQuery(hql);
            ds = query.list();
        } catch (HibernateException ex) {
            System.err.println(ex);
        } finally {
            session.close();
        }
        return ds;
    }

    public static boolean addKH(KhachHang kh)
    {
        Session session = HibernateUtil.getSessionFactory().openSession();
        Transaction transaction = null;
        try {
            transaction = session.beginTransaction();
            session.saveOrUpdate(kh);
            transaction.commit();
        } catch (Exception e) {
            // TODO: handle exception
            System.err.println(e);
            transaction.rollback();
            return false;
        }
        finally {
            session.close();
        }
        return true;
    }

    public static boolean upKH(KhachHang kh)
    {
        Session session = HibernateUtil.getSessionFactory().openSession();
        Transaction transaction = null;
        try {
            transaction = session.beginTransaction();
            session.saveOrUpdate(kh);
            transaction.commit();
        } catch (Exception e) {
            // TODO: handle exception
            System.err.println(e);
            transaction.rollback();
            return false;
        }
        finally {
            session.close();
        }
        return true;
    }

}

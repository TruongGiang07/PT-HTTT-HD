package bankmgmt.DataAccessLayer;


import bankmgmt.POJO.NhanVien;
import bankmgmt.Utilities.HibernateUtil;
import org.hibernate.HibernateException;
import org.hibernate.Session;
import org.hibernate.Transaction;
import org.hibernate.query.Query;

import java.util.List;

/**
 * Created by TruongGiang on 5/7/2017.
 */
public class NhanVienDAL {
    public static List<NhanVien> getAll()
    {
        List<NhanVien> ds = null;
        Session session = HibernateUtil.getSessionFactory().openSession();
        try {
            String hql = "select nv from NhanVien nv";
            Query query = session.createQuery(hql);
            ds = query.list();
        } catch (HibernateException ex) {
            System.err.println(ex);
        } finally {
            session.close();
        }
        return ds;
    }
    public static boolean add(NhanVien nv)
    {
        Session session = HibernateUtil.getSessionFactory().openSession();
        Transaction transaction = null;
        try {
            transaction = session.beginTransaction();
            session.saveOrUpdate(nv);
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
    public static boolean up(NhanVien nv)
    {
        Session session = HibernateUtil.getSessionFactory().openSession();
        Transaction transaction = null;
        try {
            transaction = session.beginTransaction();
            session.saveOrUpdate(nv);
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

    public static boolean del(NhanVien nv) {

        Session session = HibernateUtil.getSessionFactory().openSession();
        Transaction transaction = null;
        try {

            transaction = session.beginTransaction();
            session.delete(nv);
            transaction.commit();

        } catch (Exception e) {

            System.err.println(e);
            transaction.rollback();
            return false;

        } finally {
            session.close();
        }
        return true;
    }
}

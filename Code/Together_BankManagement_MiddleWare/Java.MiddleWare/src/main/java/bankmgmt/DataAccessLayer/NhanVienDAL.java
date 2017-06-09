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
    public static List<Object[]> getAll()
    {
        List<Object[]> ds = null;
        Session session = HibernateUtil.getSessionFactory().openSession();
        try {
            String hql = "select nv.maNhanVien, nv.hoTen, nv.ngaySinh, nv.soDienThoai, nv.diaChi, nv.gioiTinh, cn.tenChiNhanh, nv.tenDangNhap, nv.matKhau " +
                    " from NhanVien nv, ChiNhanh cn " +
                    " where nv.maCNLamViec = cn.maChiNhanh";
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
    public static List<Object[]> getNVByID( int manv)
    {
        List<Object[]> ds = null;
        Session session = HibernateUtil.getSessionFactory().openSession();
        try {
            String hql = "select nv.maNhanVien, nv.hoTen, nv.ngaySinh, nv.soDienThoai, nv.diaChi, nv.gioiTinh, cn.tenChiNhanh, nv.tenDangNhap, nv.matKhau " +
                    " from NhanVien nv, ChiNhanh cn" +
                    " where nv.maCNLamViec = cn.maChiNhanh and nv.maNhanVien = " + manv;
            Query query = session.createQuery(hql);
            ds = query.list();
        } catch (HibernateException ex) {
            System.err.println(ex);
        } finally {
            session.close();
        }
        return ds;
    }

    public static List<Object[]> getNVByHoTen(String hoten)
    {
        List<Object[]> ds = null;
        Session session = HibernateUtil.getSessionFactory().openSession();
        try {
            String hql = "select nv.maNhanVien, nv.hoTen, nv.ngaySinh, nv.soDienThoai, nv.diaChi, nv.gioiTinh, cn.tenChiNhanh, nv.tenDangNhap, nv.matKhau " +
                    " from NhanVien nv, ChiNhanh cn" +
                    " where nv.maCNLamViec = cn.maChiNhanh and nv.hoTen LIKE '%"+hoten+"%' ";
            Query query = session.createQuery(hql);
            ds = query.list();
        } catch (HibernateException ex) {
            System.err.println(ex);
        } finally {
            session.close();
        }
        return ds;
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

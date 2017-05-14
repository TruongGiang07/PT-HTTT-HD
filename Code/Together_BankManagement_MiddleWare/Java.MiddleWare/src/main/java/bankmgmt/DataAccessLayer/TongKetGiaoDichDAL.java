package bankmgmt.DataAccessLayer;

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
}

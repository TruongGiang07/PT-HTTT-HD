package bankmgmt.DataAccessLayer;

import bankmgmt.POJO.ChiNhanh;
import bankmgmt.Utilities.HibernateUtil;
import org.hibernate.HibernateException;
import org.hibernate.Session;
import org.hibernate.query.Query;

import java.util.List;

/**
 * Created by TruongGiang on 5/18/2017.
 */
public class ChiNhanhDAL {
    public static List<ChiNhanh> getAll()
    {
        List<ChiNhanh> ds = null;
        Session session = HibernateUtil.getSessionFactory().openSession();
        try {
            String hql = "select cn from ChiNhanh cn";
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

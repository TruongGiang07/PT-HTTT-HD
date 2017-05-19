package bankmgmt.DataAccessLayer;

import bankmgmt.POJO.TruSo;
import bankmgmt.Utilities.HibernateUtil;
import org.hibernate.HibernateException;
import org.hibernate.Session;
import org.hibernate.query.Query;

import java.util.List;

/**
 * Created by TruongGiang on 5/18/2017.
 */
public class TruSoDAL {
    public static List<TruSo> getAll()
    {
        List<TruSo> ds = null;
        Session session = HibernateUtil.getSessionFactory().openSession();
        try {
            String hql = "select ts from TruSo ts";
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

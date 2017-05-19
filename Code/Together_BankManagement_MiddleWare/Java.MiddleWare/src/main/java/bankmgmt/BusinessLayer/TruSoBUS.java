package bankmgmt.BusinessLayer;

import bankmgmt.DataAccessLayer.TruSoDAL;
import bankmgmt.POJO.TruSo;

import java.util.List;

/**
 * Created by TruongGiang on 5/18/2017.
 */
public class TruSoBUS {
    public static List<TruSo> getAll(){
        return TruSoDAL.getAll();
    }
}

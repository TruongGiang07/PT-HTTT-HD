package bankmgmt.BusinessLayer;

import bankmgmt.DataAccessLayer.ChiNhanhDAL;
import bankmgmt.POJO.ChiNhanh;

import java.util.List;

/**
 * Created by TruongGiang on 5/18/2017.
 */
public class ChiNhanhBUS {
    public static List<ChiNhanh> getAll(){
        return ChiNhanhDAL.getAll();
    }
}

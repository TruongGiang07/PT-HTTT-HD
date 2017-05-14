package bankmgmt.BusinessLayer;

import bankmgmt.DataAccessLayer.TongKetGiaoDichDAL;
import bankmgmt.POJO.TongKetGiaoDich;

import java.util.List;

/**
 * Created by TruongGiang on 5/7/2017.
 */
public class TongKetGiaoDichBUS {
    public static List<TongKetGiaoDich> getAll(){
        return TongKetGiaoDichDAL.getAll();
    }
}

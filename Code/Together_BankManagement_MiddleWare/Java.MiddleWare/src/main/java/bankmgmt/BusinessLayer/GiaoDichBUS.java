package bankmgmt.BusinessLayer;

import bankmgmt.DataAccessLayer.GiaoDichDAL;
import bankmgmt.POJO.GiaoDich;
import java.util.List;

/**
 * Created by TruongGiang on 5/7/2017.
 */
public class GiaoDichBUS {
    public static List<GiaoDich> getAll(){
        return GiaoDichDAL.getAll();
    }
	
	public static List<GiaoDich> getGDByKHCMND(String cmnd){
        return GiaoDichDAL.getGDByKHCMND(cmnd);
    }
	
	public static List<GiaoDich> getGDByDate(String ngaygd){
        return GiaoDichDAL.getGDByDate(ngaygd);
    }
}

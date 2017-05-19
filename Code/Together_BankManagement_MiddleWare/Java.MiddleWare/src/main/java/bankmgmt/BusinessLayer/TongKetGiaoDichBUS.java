package bankmgmt.BusinessLayer;

import bankmgmt.DataAccessLayer.TongKetGiaoDichDAL;
import bankmgmt.POJO.TKGDFilter;
import bankmgmt.POJO.TKGDViewModel;
import bankmgmt.POJO.TongKetGiaoDich;

import java.sql.Date;
import java.util.ArrayList;
import java.util.List;

/**
 * Created by TruongGiang on 5/7/2017.
 */
public class TongKetGiaoDichBUS {
    public static List<TongKetGiaoDich> getAll(){
        return TongKetGiaoDichDAL.getAll();
    }

    public static List<TKGDViewModel> getByFilter(TKGDFilter filter){
        List<TKGDViewModel> result = new ArrayList<TKGDViewModel>();
        List<Object[]> temp = TongKetGiaoDichDAL.getByFilter(filter);

        for (Object[] obj : temp) {
            TKGDViewModel item = new TKGDViewModel();
            item.setNgayGiaoDich(Date.valueOf(obj[0].toString()));
            item.setTenTruSo(obj[1].toString());
            item.setTenChiNhanh(obj[2].toString());
            item.setSlGDRutTien(Integer.valueOf(obj[3].toString()));
            item.setSoTienGDRutTien(Double.valueOf(obj[4].toString()));
            item.setSlGDGuiTien(Integer.valueOf(obj[5].toString()));
            item.setSoTienGDGuiTien(Double.valueOf(obj[6].toString()));
            item.setSlGDChuyenTien(Integer.valueOf(obj[7].toString()));
            item.setSoTienGDChuyenTien(Double.valueOf(obj[8].toString()));
            result.add(item);
        }
        return result;
    }
}

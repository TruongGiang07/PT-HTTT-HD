package bankmgmt.BusinessLayer;

import bankmgmt.DataAccessLayer.TongKetGiaoDichDAL;
import bankmgmt.POJO.*;

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
            item.setMaTruSo(Integer.valueOf(obj[9].toString()));
            item.setMaChiNhanh(Integer.valueOf(obj[10].toString()));
            result.add(item);
        }
        return result;
    }

    public static List<TKGDDetailViewModel> getDSGDByNgay(TKGDDetailParam opt){
        List<TKGDDetailViewModel> result = new ArrayList<TKGDDetailViewModel>();
        List<Object[]> temp = TongKetGiaoDichDAL.getDSGDByNgay(opt);
        for (Object[] obj : temp) {
            TKGDDetailViewModel item = new TKGDDetailViewModel();
            item.setMaKhachHang(Integer.valueOf(obj[0].toString()));
            item.setHoTen(obj[1].toString());
            item.setSoCMND(obj[2].toString());
            item.setSoTienGD(Double.valueOf(obj[3].toString()));
            item.setLoaiGD(obj[4].toString());
            result.add(item);
        }
        return result;
    }

    public static TKGDTotal getTotalByFilter(TKGDFilter filter){
        TKGDTotal result = new TKGDTotal();
        List<Object[]> temp = TongKetGiaoDichDAL.getTotalByFilter(filter);
        for (Object[] obj : temp) {
            result.setSumSLGDRutTien(Integer.valueOf(obj[0].toString()));
            result.setSumSoTienGDRutTien(Double.valueOf(obj[1].toString()));
            result.setSumSLGDGuiTien(Integer.valueOf(obj[2].toString()));
            result.setSumSoTienGDGuiTien(Double.valueOf(obj[3].toString()));
            result.setSumSLGDChuyenTien(Integer.valueOf(obj[4].toString()));
            result.setSumSoTienGDChuyenTien(Double.valueOf(obj[5].toString()));
        }
        return result;
    }
}

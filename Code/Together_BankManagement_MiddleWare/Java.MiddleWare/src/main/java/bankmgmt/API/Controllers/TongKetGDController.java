package bankmgmt.API.Controllers;

import bankmgmt.BusinessLayer.TongKetGiaoDichBUS;
import bankmgmt.POJO.TKGDDetailParam;
import bankmgmt.POJO.TKGDDetailViewModel;
import bankmgmt.POJO.TKGDFilter;
import bankmgmt.POJO.TKGDViewModel;
import org.springframework.http.MediaType;
import org.springframework.web.bind.annotation.RequestBody;
import org.springframework.web.bind.annotation.RequestMapping;
import org.springframework.web.bind.annotation.RequestMethod;
import org.springframework.web.bind.annotation.RestController;

import java.util.List;

/**
 * Created by TruongGiang on 5/7/2017.
 */

@RequestMapping("/api/tongketgd")
@RestController
public class TongKetGDController {

    @RequestMapping(value = "gettkgd", method = RequestMethod.POST, produces = {MediaType.APPLICATION_JSON_VALUE})
    public List<TKGDViewModel> GetTKGDByFilter(@RequestBody TKGDFilter filter) {
        return TongKetGiaoDichBUS.getByFilter(filter);
    }

    @RequestMapping(value = "getDSGDByNgay", method = RequestMethod.POST, produces = {MediaType.APPLICATION_JSON_VALUE})
    public List<TKGDDetailViewModel> GetDSGDByNgay(@RequestBody TKGDDetailParam opt) {
        return TongKetGiaoDichBUS.getDSGDByNgay(opt);
    }
}

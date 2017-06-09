package bankmgmt.API.Controllers;

import bankmgmt.BusinessLayer.TongKetGiaoDichBUS;
import bankmgmt.POJO.*;
import org.springframework.http.MediaType;
import org.springframework.web.bind.annotation.*;

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

    @RequestMapping(value = "getTotalByFilter", method = RequestMethod.POST, produces = {MediaType.APPLICATION_JSON_VALUE})
    @CrossOrigin()
    public TKGDTotal getTotalByFilter(@RequestBody TKGDFilter filter) {
        return TongKetGiaoDichBUS.getTotalByFilter(filter);
    }
}

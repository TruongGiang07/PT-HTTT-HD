package bankmgmt.API.Controllers;

import bankmgmt.BusinessLayer.TongKetGiaoDichBUS;
import bankmgmt.POJO.TongKetGiaoDich;
import org.springframework.http.MediaType;
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

    @RequestMapping(value = "all", method = RequestMethod.GET, produces = {MediaType.APPLICATION_JSON_VALUE})
    public List<TongKetGiaoDich> GetAll() {
        List<TongKetGiaoDich> listTKGD = TongKetGiaoDichBUS.getAll();
        return listTKGD;
    }
}

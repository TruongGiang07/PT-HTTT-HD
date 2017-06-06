package bankmgmt.API.Controllers;

import bankmgmt.BusinessLayer.GiaoDichBUS;
import bankmgmt.POJO.GiaoDich;
import org.springframework.http.MediaType;
import org.springframework.web.bind.annotation.RequestMapping;
import org.springframework.web.bind.annotation.RequestMethod;
import org.springframework.web.bind.annotation.RestController;

import java.util.List;

/**
 * Created by TruongGiang on 5/18/2017.
 */

@RequestMapping("/api/giaodich")
@RestController
public class GiaoDichController {

    @RequestMapping(value = "all", method = RequestMethod.GET, produces = {MediaType.APPLICATION_JSON_VALUE})
    public List<GiaoDich> GetAll() {
        List<GiaoDich> listGD = GiaoDichBUS.getAll();
		return listGD;
    }
	
	@RequestMapping(value = "/{cmnd}", method = RequestMethod.GET, produces = {MediaType.APPLICATION_JSON_VALUE})
    public List<GiaoDich> GetGDByKHCMND(@PathVariable @RequestParam(value="cmnd") String cmnd) {
        List<GiaoDich> listGD = GiaoDichBUS.getGDByKHCMND(cmnd);
        return listGD;
    }
	
	@RequestMapping(value = "/{ngaygd}", method = RequestMethod.GET, produces = {MediaType.APPLICATION_JSON_VALUE})
    public List<GiaoDich> GetGDByKHCMND(@PathVariable @RequestParam(value="ngaygd") String ngaygd) {
        List<GiaoDich> listGD = GiaoDichBUS.getGDByDate(ngaygd);
        return listGD;
    }
}

package bankmgmt.API.Controllers;

import bankmgmt.BusinessLayer.KhachHangBUS;
import bankmgmt.POJO.KhachHang;
import org.springframework.http.HttpStatus;
import org.springframework.http.MediaType;
import org.springframework.http.ResponseEntity;
import org.springframework.web.bind.annotation.*;

import java.util.List;

/**
 * Created by TruongGiang on 5/7/2017.
 */

@RequestMapping("/api/kh")
@RestController
public class KhachHangController {

    @RequestMapping(value = "all", method = RequestMethod.GET, produces = {MediaType.APPLICATION_JSON_VALUE})
    public List<KhachHang> GetAll() {
        List<KhachHang> listKH = KhachHangBUS.getAll();
        return listKH;
    }

    @RequestMapping(value = "id/{makh}", method = RequestMethod.GET, produces = {MediaType.APPLICATION_JSON_VALUE})
    public List<KhachHang> GetKHById(@PathVariable int makh) {
        List<KhachHang> listKH = KhachHangBUS.getKHByID(makh);
        return listKH;
    }
	
	@RequestMapping(value = "cmnd/{cmnd}", method = RequestMethod.GET, produces = {MediaType.APPLICATION_JSON_VALUE})
	@CrossOrigin()
    public List<KhachHang> GetKHByCMND(@PathVariable String cmnd) {
        List<KhachHang> listKH = KhachHangBUS.getKHByCMND(cmnd);
        return listKH;
    }

    @RequestMapping(value = "addkh", method = RequestMethod.POST, produces = {MediaType.APPLICATION_JSON_VALUE})
    public ResponseEntity<KhachHang> AddKH(@RequestBody KhachHang kh) {
        if (kh != null && KhachHangBUS.addKH(kh)) {
            return new ResponseEntity<KhachHang>(kh, HttpStatus.CREATED);
        } else {
            return new ResponseEntity<KhachHang>(kh, HttpStatus.NOT_MODIFIED);
        }
    }

    @RequestMapping(value = "upkh", method = RequestMethod.POST, produces = {MediaType.APPLICATION_JSON_VALUE})
    public ResponseEntity<KhachHang> UpKH(@RequestBody KhachHang kh) {
        if (kh != null && KhachHangBUS.upKH(kh)) {
            return new ResponseEntity<KhachHang>(kh, HttpStatus.CREATED);
        } else {
            return new ResponseEntity<KhachHang>(kh, HttpStatus.NOT_MODIFIED);
        }
    }

    @RequestMapping(value = "delkh/{makh}", method = RequestMethod.POST, produces = {MediaType.APPLICATION_JSON_VALUE})
    public ResponseEntity<KhachHang> DelKH(@PathVariable int makh) {
        KhachHang kh = KhachHangBUS.getKHByID(makh).get(0);
        if (kh != null && KhachHangBUS.delKH(kh)) {
            return new ResponseEntity<KhachHang>(kh, HttpStatus.CREATED);
        } else {
            return new ResponseEntity<KhachHang>(kh, HttpStatus.NOT_MODIFIED);
        }
    }

}

import { Component, OnInit, ViewEncapsulation } from '@angular/core';
import { FormControl } from '@angular/forms';
import { AppService } from '../app.service';

@Component({
  selector: 'shop',
  templateUrl: './shop.component.html',
  styleUrls: ['./shop.component.scss'],
  encapsulation: ViewEncapsulation.None
})
export class ShopComponent implements OnInit {

  search: FormControl = new FormControl();

  panelOpenState = false;
  listProducts: any;
  isSearch: boolean;

  constructor(private appService: AppService) { }

  ngOnInit() {
    this.getProducts();
  }

  searchProduct(): void {
    this.getProducts();
    this.isSearch = true;
  }

  deleteSearch(): void {
    this.search.setValue('');
    this.getProducts();
    this.isSearch = false;
  }

  getProducts(): void {
    this.appService.getShop(this.search.value).subscribe((data) => {
      this.listProducts = data.reduce((res, item) => {
        const valueList = item.List.reduce((res, item) => {
          const value = {
            ...item,
            link: `http/my-shop/${item.Name}/${item.Id}`
          }

          res.push(value);
          return res;
        }, [])

        const subject = {
          ...item,
          List: valueList,
          link: `http/my-shop/${item.Name}/${item.Id}`
        }

        res.push(subject);
        return res;
      }, [])
    });
  }
}

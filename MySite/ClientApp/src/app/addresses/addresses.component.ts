import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-addresses',
  templateUrl: './addresses.component.html'
})
export class AddressesComponent implements OnInit {

  constructor() { }

  ngOnInit() {
  }

}

export interface Address {
  addressId: number;
  streetAddress: string;
  city: string;
  state: string;
  zip: string;
}

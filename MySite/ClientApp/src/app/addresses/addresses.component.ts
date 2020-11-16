import { Component, OnInit } from '@angular/core';
import { HttpClient } from '@angular/common/http';

@Component({
  selector: 'app-addresses',
  templateUrl: './addresses.component.html'
})
export class AddressesComponent implements OnInit {

  public addresses: Address[] = null;

  public newAddress: Address = null;

  constructor(private http: HttpClient) { }

  ngOnInit() {
    this.refreshAddresses();
  }

  refreshAddresses(): void {
    this.http.get<Address[]>("https://localhost:44378/Address")
      .subscribe(addressesResult => { this.addresses = addressesResult; });
  }

  toggleNewAddress(): void {
    if (this.newAddress)
      this.newAddress = null;
    else
      this.newAddress = <Address>{};
  }

  addNewAddress(): void {
    this.http.post("https://localhost:44378/Address", this.newAddress).subscribe(() => {
      this.newAddress = null;

      this.refreshAddresses();
    });
  }
}

export interface Address {
  addressId: number;
  streetAddress: string;
  city: string;
  state: string;
  zip: string;
}

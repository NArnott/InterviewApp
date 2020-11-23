import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-users',
  templateUrl: './users.component.html'
})
export class UsersComponent implements OnInit {

  constructor() { }

  ngOnInit() {
  }

}

export interface User {
  userId: number;
  username: string;
  emailAddress: string;
}

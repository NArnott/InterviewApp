import { Component, OnInit } from '@angular/core';
import { HttpClient } from '@angular/common/http';

@Component({
  selector: 'app-users',
  templateUrl: './users.component.html'
})
export class UsersComponent implements OnInit {

  public users: User[] = null;

  public newUser: User = null;

  constructor(private http: HttpClient) { }

  ngOnInit() {
    this.refreshUsers();
  }

  refreshUsers(): void {
    this.http.get<User[]>("https://localhost:44378/User")
      .subscribe(userResults => { this.users = userResults; });
  }

  toggleNewUser(): void {
    if (this.newUser)
      this.newUser = null;
    else
      this.newUser = <User>{};
  }

  addNewUser(): void {
    this.http.post("https://localhost:44378/User", this.newUser).subscribe(() => {
      this.newUser = null;

      this.refreshUsers();
    });
  }

}

export interface User {
  userId: number;
  username: string;
  emailAddress: string;
}

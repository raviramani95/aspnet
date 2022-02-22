import { HttpClient } from '@angular/common/http';
import { Component, Input, OnInit } from '@angular/core';

@Component({
  selector: 'app-home',
  templateUrl: './home.component.html',
  styleUrls: ['./home.component.css']
})
export class HomeComponent implements OnInit {

  // @Input() usersFromHomeComponent: any;
  registerMode = false;
  // users: any;

  constructor() { }

  ngOnInit(): void {
    // this.getUsers();
  }

  registerToggel(){
    this.registerMode = !this.registerMode;
  }
  
  // getUsers(){
  //   this.http.get('https://localhost:5001/api/users').subscribe(x => this.users = x);
  // }

  cancelRegisterMode(event: boolean){
    this.registerMode = event;
  }
}

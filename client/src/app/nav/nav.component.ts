import { Component, OnInit } from '@angular/core';
import { Observable } from 'rxjs/internal/Observable';
import { User } from '../_models/user';
import { AccountService } from '../_services/account.service';

@Component({
  selector: 'app-nav',
  templateUrl: './nav.component.html',
  styleUrls: ['./nav.component.css']
})
export class NavComponent implements OnInit {

  model: any = {};
  // loggedIn: boolean;
  // currentUser$: Observable<User>;

  constructor(public accountServices: AccountService) {}

  ngOnInit(): void {
    // this.currentUser$ = this.accountServices.currentUser$; 
    // this.getCurrentUser();
  }

  login(){
    this.accountServices.login(this.model).subscribe(response => {
        console.log(response);
        // this.loggedIn = true;
    }, error => {
      console.log(error);
    })
  }

  logout(){ 
    this.model.username ='';
    this.model.password = ''
    this.accountServices.logout();
    // this.loggedIn = false;
  }

  // getCurrentUser(){
  //   this.accountServices.currentUser$.subscribe(user =>{
  //     this.loggedIn = !!user;
  //   },error =>{
  //     console.log(error);
  //   })
  // }

}

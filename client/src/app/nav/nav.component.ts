import { Component, OnInit } from '@angular/core';
import { Router } from '@angular/router';
import { ToastrService } from 'ngx-toastr';
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

  constructor(
    public accountServices: AccountService, 
    private router: Router, 
    private toastr: ToastrService 
  ){}

  ngOnInit(): void {
    // this.currentUser$ = this.accountServices.currentUser$; 
    // this.getCurrentUser();
  }

  login(){
    this.accountServices.login(this.model).subscribe(response => {
      this.router.navigateByUrl('/members');
        // console.log(response);
        // this.loggedIn = true;
    })
  }

  logout(){ 
    this.model.username ='';
    this.model.password = ''
    this.accountServices.logout();
    this.router.navigateByUrl('/');
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

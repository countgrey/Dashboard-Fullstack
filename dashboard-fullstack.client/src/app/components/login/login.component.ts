import { Component, OnInit } from '@angular/core';
import { FormBuilder, FormGroup } from '@angular/forms';
import { Router } from "@angular/router"
import sqlite3 from 'sqlite3'
import { open } from 'sqlite'

@Component({
  selector: 'app-login',
  templateUrl: './login.component.html',
  styleUrl: './login.component.css'
})

export class LoginComponent implements OnInit {

  loginForm!: FormGroup;
  constructor(private fb: FormBuilder, private router: Router) { }

  ngOnInit(): void {

    this.loginForm = this.fb.group({
      username: [''],
      password: ['']
    });
  }

   onSubmit(): void{
    if(this.loginForm.valid)
    {
        //Авторизация прошла
        //this.router.navigate(['/dashboard']);

    }
    else
    {
        //Иди нахуй
        console.log("Иди нахуй");
    }
  }
}

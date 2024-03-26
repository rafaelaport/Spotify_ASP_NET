import { Routes } from '@angular/router';
import { HomeComponent } from './home/home.component';
import { DetailBandaComponent } from './detail-banda/detail-banda.component';
import { LoginComponent } from './login/login.component';
import { UsuarioComponent } from './usuario/usuario.component';

export const routes: Routes = [
    {
        path: '',
        component: LoginComponent
    },
    {
        path: 'home',
        component: HomeComponent

    },
    {
        path: 'detail/:id',
        component: DetailBandaComponent
    },
    {
        path: 'usuario',
        component: UsuarioComponent
    }
];
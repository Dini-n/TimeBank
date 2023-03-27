import { Injectable } from '@angular/core';

@Injectable({
  providedIn: 'root'
})
export class UrlsService {
  urlApi = "https://localhost:44357/api/";
  constructor() { }
}

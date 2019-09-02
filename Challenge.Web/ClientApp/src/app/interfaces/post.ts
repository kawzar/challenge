import { User } from './user';

export interface Post {
    Id: number,
    Title: string;
    Content: string;
    Author: User
}

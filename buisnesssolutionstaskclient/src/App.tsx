import { BrowserRouter, Route, Routes } from 'react-router-dom';
import './App.css'
import MainPage from './pages/MainPage';
import EditOrderPage from './pages/EditOrderPage';
import ViewOrderPage from './pages/ViewOrderPage';

function App() {
    return (
        <BrowserRouter>
            <Routes>
                <Route element={<MainPage />} path="/" />
                <Route element={<EditOrderPage />} path="/edit" />
                <Route element={<ViewOrderPage />} path="/view" />
            </Routes>
        </BrowserRouter>
    )
}

export default App
